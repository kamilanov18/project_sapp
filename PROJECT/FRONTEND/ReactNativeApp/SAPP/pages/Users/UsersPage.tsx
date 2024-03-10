import React, { useContext } from "react";
import { Button } from "react-native-ui-lib";
import ServiceContext from "../../components/ServiceContext";
export default function UsersPage({navigation}) {
    const ctx = useContext(ServiceContext);
    return (
        <>
            <Button label={ctx.Translate.get("users-page.register")} backgroundColor={"green"} onPress={()=>{navigation.navigate("RegisterUserPage")}}/>
        </>
    );
}