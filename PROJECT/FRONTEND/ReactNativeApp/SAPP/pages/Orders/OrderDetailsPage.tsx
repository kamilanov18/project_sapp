import React, { useContext, useEffect, useState } from "react";
import {SafeAreaView, Text, View} from 'react-native'
import {OrderDetailsDTO} from '../../../../Common/DTOs/OrderDetailsDTO'
import ServiceContext from "../../components/ServiceContext";
import StyleContext from "../../components/StyleContext";
import { ScrollView } from "react-native";
import { LoaderScreen } from "react-native-ui-lib";
import DisplayDrawerComponent from "../../components/DisplayDrawerComponent";

interface OrderDetailsPageProps {
    orderId: number,
    route: any
}

export default function OrderDetailsPage({route}:OrderDetailsPageProps) {

    const ctx = useContext(ServiceContext);
    const styles = useContext(StyleContext);
    const [order,setOrder] = useState<OrderDetailsDTO>();

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
                </View>

                
            }
        </ScrollView>
    </SafeAreaView>);
}