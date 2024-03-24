import React, { useContext } from "react";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { Drawer, DrawerItemProps, DrawerProps, View } from "react-native-ui-lib";
import { OrderDTO } from "../../../Common/DTOs/OrderDTO";
import {ProductItemDTO} from "../../../Common/DTOs/ProductItemDTO";
import {Text} from 'react-native';
import StatusIcon from "./StatusIcon";
import StyleContext from "./StyleContext";
import ServiceContext from "./ServiceContext";

interface OrderDrawerComponentProps {
    orders: OrderDTO[],
    navigation: any
}

export default function OrderDrawerComponent({orders,navigation}:OrderDrawerComponentProps) {

    const styles = useContext(StyleContext);
    const ctx = useContext(ServiceContext);
    
    return(
        <GestureHandlerRootView>
            {orders.map((order: OrderDTO) =>
                
                <Drawer
                    leftItem={{
                        text: ctx.Translate.get('orders-page.open-details'),
                        onPress:()=>{console.log(order.id); navigation.navigate('OrderDetailsPage',{orderId:order.id});},
                        background: styles.primary.backgroundColor,
                    }}
                    useNativeAnimations
                >
                    <View centerV padding-s4 bg-white style={order.isPossibleDuplicate?styles.duplicateDrawerItem:styles.drawerItem}>
                        <View style={{flex:0.5,justifyContent:'center'}}>
                            <StatusIcon id={order.statusId} size={20} />
                        </View>
                        
                        <View style={{flex:5.5}}>
                            <Text >{order.clientFirstName} {order.clientLastName}</Text>
                            <Text style={styles.primaryText}>{order.clientAddress}</Text>
                            {order.products.map((p:ProductItemDTO)=>{
                                return(
                                    <Text>{p.name} - {p.count}</Text>
                                )
                            })}
                        </View>
                    </View>
                </Drawer>
            )}
        </GestureHandlerRootView>
    );
}