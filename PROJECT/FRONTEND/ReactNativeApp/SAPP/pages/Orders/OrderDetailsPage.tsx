import React, { useContext, useEffect, useState } from "react";
import {SafeAreaView, Text, View} from 'react-native'
import {OrderDetailsDTO} from '../../../../Common/DTOs/OrderDetailsDTO'
import ServiceContext from '../../components/ServiceContext';
import StyleContext from "../../components/StyleContext";
import { ScrollView } from "react-native";
import { ExpandableSection, LoaderScreen, Picker, PickerValue, TextField } from "react-native-ui-lib";
import DisplayDrawerComponent from "../../components/DisplayDrawerComponent";
import { NomenclatureDTO } from '../../../../Common/DTOs/NomenclatureDTO';

interface OrderDetailsPageProps {
    orderId: number,
    route: any
}

export default function OrderDetailsPage({route}:OrderDetailsPageProps) {

    const ctx = useContext(ServiceContext);
    const styles = useContext(StyleContext);
    const [order,setOrder] = useState<OrderDetailsDTO>();
    const [econtCities,setEcontCities] = useState<NomenclatureDTO<number>[]>();
    const [econtStreets,setEcontStreets] = useState<NomenclatureDTO<number>[]>();

    const onEcontCountriesChange = (val: PickerValue) => {
        (async ()=>{
            const cachedCities = ctx.Cache.get(val?.toString() as string);
            if(cachedCities) {
                setEcontCities(cachedCities);
            } else {
                const response = await ctx.Nomenclatures.GetEcontCities(val?.toString() as string);
                ctx.Cache.set(val?.toString() as string,response.data);
                setEcontCities(response.data);
            }
        })()
    }

    const onEcontCitiesChanged = (val: PickerValue) => {
        (async ()=>{
            const cachedStreets = ctx.Cache.get(val?.toString() as string);
            if(cachedStreets) {
                setEcontStreets(cachedStreets);
            } else {
                const response = await ctx.Nomenclatures.GetEcontStreets(parseInt(val?.toString() as string));
                ctx.Cache.set(val?.toString() as string,response.data);
                setEcontStreets(response.data);
            }
        })()
    }

    useEffect(()=>{
        (async ()=>{
            console.log("asdasdsad ",route.params.orderId);
            setOrder((await ctx.Orders.get(route.params.orderId)).data as OrderDetailsDTO);
            console.log(order);
        })()
    },[]);

    return (
    <SafeAreaView>
        <ScrollView>
            {!order?<LoaderScreen message={ctx.Translate.get('common.loading')} />:
                <View>
                    {order.isPossibleDuplicate?<Text>{ctx.Translate.get('order-details-page.duplicated')}</Text>:null}
                    <Text>{order.clientFirstName} {order.clientLastName}</Text>
                    

                    {!order.previousOrders?null:
                        <>
                            <Text style={{justifyContent:'center'}}> {ctx.Translate.get("order-details-page.previous-orders")} </Text>
                            <ScrollView style={{margin:10}}>
                                <DisplayDrawerComponent orders={order.previousOrders} />
                            </ScrollView>
                        </>
                    }

                    <Text>{order.providedAddress}</Text>
                    <ExpandableSection
                     top
                     expanded={false}
                     sectionHeader={<Text>Econt</Text>}
                     onPress={() => console.log('pressed')}
                    >
                        {/* Country picker */}
                        <Picker items={ctx.Cache.get("econt-countries")??ctx.Nomenclatures.getEcontCountries()}
                            onChange={onEcontCountriesChange}
                        />
                        {/* City picker */}
                        <Picker items={econtCities as any}
                            onChange={onEcontCitiesChanged}
                            />
                        {/* Street picker */}
                        <Picker items={econtStreets as any}
                            />

                        <TextField placeholder={ctx.Translate.get("order-details-street-num")} />
                    </ExpandableSection>
                    <ExpandableSection
                     top
                     expanded={false}
                     sectionHeader={<Text>Speedy</Text>}
                     onPress={() => console.log('pressed')}
                    >

                    </ExpandableSection>
                </View>
            }
        </ScrollView>
    </SafeAreaView>);
}