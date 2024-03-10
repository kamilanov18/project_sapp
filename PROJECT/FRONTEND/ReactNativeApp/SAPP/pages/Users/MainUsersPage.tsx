import { createNativeStackNavigator } from "@react-navigation/native-stack";
import React, { useContext } from "react";
import UsersPage from "./UsersPage";
import ServiceContext from "../../components/ServiceContext";
import RegisterUserPage from "./RegisterUserPage";

const Stack = createNativeStackNavigator();

export default function MainUsersPage() {
    const ctx = useContext(ServiceContext);
    return (
        <Stack.Navigator initialRouteName="UsersPage" >
            <Stack.Screen
              name="UsersPage"
              component={UsersPage}
              options={{ title: ctx.Translate.get('user-page.title'), }}
            />
            <Stack.Screen
              name="RegisterUserPage"
              component={RegisterUserPage}
              options={{ title: ctx.Translate.get('register-user-page.title'), }}
            />
        </Stack.Navigator>
    );
}