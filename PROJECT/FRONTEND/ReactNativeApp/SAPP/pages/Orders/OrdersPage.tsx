import React, { useContext, useEffect, useRef, useState } from "react";
import { OrderDTO } from '../../../../Common/DTOs/OrderDTO';
import ServiceContext from "../../components/ServiceContext";
import OrderDrawerComponent from "../../components/OrderDrawerComponent";
import { ScrollView, View } from "react-native";
import { SafeAreaView } from "react-native";
import { LoaderScreen } from "react-native-ui-lib";

export default function OrdersPage({navigation}) {
    const [orders,setOrders] = useState<OrderDTO[]>();
    const ctx = useContext(ServiceContext);

    useEffect(()=>{
        (async ()=>{
            setOrders((await ctx.Orders.getAll()).data as OrderDTO[]);
            console.log(orders);
        })()
    },[])

    return (
        <SafeAreaView>
            <ScrollView>
            {!orders?<View><LoaderScreen message={ctx.Translate.get('common.loading')} /></View>:
                <OrderDrawerComponent 
                    orders={orders}
                    navigation={navigation}
                />
            }
            </ScrollView>
        </SafeAreaView>
    );
}