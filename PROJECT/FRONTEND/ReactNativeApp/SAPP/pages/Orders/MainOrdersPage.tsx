import { createNativeStackNavigator } from "@react-navigation/native-stack";
import React, { useContext } from "react";
import ServiceContext from "../../components/ServiceContext";
import OrdersPage from "./OrdersPage";
import OrderDetailsPage from "./OrderDetailsPage";

const Stack = createNativeStackNavigator();

export default function MainOrdersPage() {
    const ctx = useContext(ServiceContext);
    return (
        <Stack.Navigator initialRouteName="UsersPage" >
            <Stack.Screen
              name="OrdersPage"
              component={OrdersPage}
              options={{ title: ctx.Translate.get('orders-page.title'), }}
            />
            <Stack.Screen
              name="OrderDetailsPage"
              component={OrderDetailsPage}
              options={{ title: ctx.Translate.get('order-details-page.title'), }}
            />
        </Stack.Navigator>
    );
}