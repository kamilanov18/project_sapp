import React, { useContext } from "react";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { Drawer, DrawerItemProps, DrawerProps, View } from "react-native-ui-lib";
import { OrderDTO } from "../../../Common/DTOs/OrderDTO";
import {Text} from 'react-native';
import StatusIcon from "./StatusIcon";
import StyleContext from "./StyleContext";
import ServiceContext from "./ServiceContext";

interface OrderDrawerComponentProps {
    orders: OrderDTO[],
}

export default function DisplayDrawerComponent({orders}:OrderDrawerComponentProps) {

    const styles = useContext(StyleContext);
    const ctx = useContext(ServiceContext);

    return(
        <GestureHandlerRootView>
            {orders.map((order: OrderDTO)=>
                <Drawer>
                    <View centerV padding-s4 bg-white style={order.isPossibleDuplicate?styles.duplicateDrawerItem:styles.drawerItem}>
                        <View style={{flex:0.5,justifyContent:'center'}}>
                            <StatusIcon id={order.statusId} size={20} tintColor="green" />
                        </View>
                        
                        <View style={{flex:5.5}}>
                            <Text >{order.clientFirstName} {order.clientLastName}</Text>
                            <Text style={styles.primaryText}>{order.clientAddress}</Text>
                            <Text>{order.products[0].name}</Text>
                        </View>
                    </View>
            </Drawer>)}
        </GestureHandlerRootView>
    );
}