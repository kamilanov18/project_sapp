import React, { useContext, useEffect, useState } from "react";
import {Text} from 'react-native'
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { Drawer, Icon, View } from "react-native-ui-lib";
import { OrderDTO } from '../../../../Common/DTOs/OrderDTO';
import { ProductItemDTO } from '../../../../Common/DTOs/ProductItemDTO';
import StyleContext from "../../components/StyleContext";
import ServiceContext from "../../components/ServiceContext";
import StatusIcon from "../../components/StatusIcon";

export default function OrdersPage({navigation}) {
    const [orders,setOrders] = useState<OrderDTO[]>([]);

    const styles = useContext(StyleContext);
    const ctx = useContext(ServiceContext);

    useEffect(()=>{
        setOrders([
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:true,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:true,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]}),
            new OrderDTO({id:1,statusId:0,clientNames:"Teodor Teodorov",isPossibleDuplicate:false,clientAddress:"Ж.К. Стрелбище. Бл. 91, Вх. А, Ап. 10",products:[new ProductItemDTO({id:1,name:"karma",count:3}),]})
        ])
    },[])

    return (
        <>
        <GestureHandlerRootView>
        {orders.map((order: OrderDTO)=>
            <Drawer
                leftItem={{text: ctx.Translate.get('orders-page.open-details'),}}
                onFullSwipeLeft={()=>{navigation.navigate('OrderDetailsPage')}}
                fullSwipeLeft
                disableHaptic
                
                fullLeftThreshold={0.25}
            >
                
                    <View centerV padding-s4 bg-white style={order.isPossibleDuplicate?styles.duplicateDrawerItem:styles.drawerItem}>
                        <View style={{flex:0.5,justifyContent:'center'}}>
                            <StatusIcon id={order.statusId} size={20} tintColor="green" />
                        </View>
                        
                        <View style={{flex:5.5}}>
                            <Text >{order.clientNames}</Text>
                            <Text style={styles.primaryText}>{order.clientAddress}</Text>
                            <Text>{order.products[0].name}</Text>
                        </View>
                    </View>
                
            </Drawer>)}
            </GestureHandlerRootView>
        </>
    );
}