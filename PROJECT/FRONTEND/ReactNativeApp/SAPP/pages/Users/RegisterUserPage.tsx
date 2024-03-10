import React, { useContext, useState } from "react";
import { Button, TextField } from "react-native-ui-lib";
import ServiceContext from "../../components/ServiceContext";
import UserDTO from "common\\DTOs\\UserDTO";
import { SafeAreaView } from "react-native";

export default function RegisterUserPage({navigation}) {
    const ctx = useContext(ServiceContext);
    const [email, setEmail] = useState('');
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [roleIds, setRoleIds] = useState([]);
    const [wage, setWage] = useState('');
    const [phone, setPhone] = useState('');

    const registerUser = async () => {
        const newUser = new UserDTO({id:0, email: email, firstName: firstName, lastName: lastName, roleIds: roleIds, wage: wage, phone: phone});
        console.log(newUser);
        await ctx.Users.register(newUser);
    }

    return (
    <>
    <SafeAreaView>
        <TextField
            placeholder={ctx.Translate.get("register-user-page.first-name")}
            floatingPlaceholder
            autoCapitalize="words"
            required
            enableErrors
            onChangeText={setFirstName}
        />
        <TextField
            placeholder={ctx.Translate.get("register-user-page.last-name")}
            floatingPlaceholder
            autoCapitalize="words"
            required
            enableErrors
            onChangeText={setLastName}
        />
        <TextField
            placeholder={ctx.Translate.get("register-user-page.email")}
            floatingPlaceholder
            required
            enableErrors
            onChangeText={setEmail}
        />
        <TextField
            placeholder={ctx.Translate.get("register-user-page.phone")}
            floatingPlaceholder
            phone
            enableErrors={true}
            required
            keyboardType="numeric"
            onChangeText={setPhone}
        />
        <TextField
            placeholder={ctx.Translate.get("register-user-page.wage")}
            floatingPlaceholder
            enableErrors
            keyboardType="numeric"
            onChangeText={setWage}
        />

        <Button label={ctx.Translate.get("register-user-page.register")} backgroundColor={"green"} onPress={registerUser}/>
    </SafeAreaView>
    </>);
}