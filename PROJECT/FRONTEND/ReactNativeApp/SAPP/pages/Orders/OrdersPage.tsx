import React, { useContext, useEffect, useState } from "react";
import {Text} from 'react-native'
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { Drawer, View } from "react-native-ui-lib";
import { OrderDTO } from '../../../../Common/DTOs/OrderDTO';
import { ProductItemDTO } from '../../../../Common/DTOs/ProductItemDTO';
import StyleContext from "../../components/StyleContext";
import ServiceContext from "../../components/ServiceContext";

export default function OrdersPage({navigation}) {
    const [orders,setOrders] = useState<OrderDTO[]>([]);

    const styles = useContext(StyleContext);
    const ctx = useContext(ServiceContext);

    useEffect(()=>{
        setOrders([
            new OrderDTO({id:1,statusId:1,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3})]})
        ])
    },[])

    return (
        <>
        <GestureHandlerRootView>
            <Drawer
                leftItem={{text: ctx.Translate.get('orders-page.open-details'), background: styles.primary.backgroundColor}}
                onSwipeableWillOpen={()=>{navigation.navigate('OrderDetailsPage')}}
            >
                {orders.map((order: OrderDTO)=>
                    <View centerV padding-s4 bg-white style={{height: 60}}>
                        <Text >{order.statusId} {order.clientNames}</Text>
                        <View>
                            <Text>{order.clientAddress}</Text>
                            <Text>{order.products[0].name}</Text>
                        </View>
                    </View>
                )}
            </Drawer>
            </GestureHandlerRootView>
        </>
    );
}