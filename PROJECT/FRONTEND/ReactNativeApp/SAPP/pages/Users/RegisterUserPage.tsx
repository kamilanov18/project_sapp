import React, { useContext, useEffect, useState } from "react";
import { Button, Incubator, Picker, TextField } from "react-native-ui-lib";
import ServiceContext from "../../components/ServiceContext";
import StyleContext from "../../components/StyleContext";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { EditUserDTO } from "../../../../Common/DTOs/EditUserDTO";
import { NomenclatureDTO } from "../../../../Common/DTOs/NomenclatureDTO";

const {Toast} = Incubator;

export default function RegisterUserPage({navigation}) {
    const ctx = useContext(ServiceContext);
    const styles = useContext(StyleContext);
    const [email, setEmail] = useState('');
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [roleIds, setRoleIds] = useState(new Array<number>());
    const [wage, setWage] = useState('');
    const [phone, setPhone] = useState('');
    const [isToastVisible, setIsToastVisible] = useState(false);
    const [toastMessage, setToastMessage] = useState('');
    const [roles, setRoles] = useState<NomenclatureDTO<number>[]>([]);
    const toggleToastVisibility = () => setIsToastVisible(!isToastVisible);

    useEffect(() => {
        (async ()=>{
            setRoles((await ctx.Roles.getAll()).data as NomenclatureDTO<number>[]);
        })()
      }, []);
    
    const registerUser = async () => {
        
        const newUser = new EditUserDTO({id:0, email: email, firstName: firstName, lastName: lastName, roleIds: roleIds, wage: +wage, phone: phone});
        const res = await ctx.Users.register(newUser);
        console.log(res);
        if(res.code==200) {
            console.log("vlizam")
            navigation.navigate("UsersPage");
        } else if (res.code==400) {
            setToastMessage(ctx.Translate.get(res.error as string));
            setIsToastVisible(true);
        }
    }

    return (
    <>
    <GestureHandlerRootView>
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

        <Picker
          placeholder={ctx.Translate.get("register-user-page.roles")}
          floatingPlaceholder
          mode={Picker.modes.MULTI}
          onChange={value => setRoleIds(value as number[])}>
            {roles.map(role => (
              <Picker.Item key={role.id} value={role.id} label={role.name}/>
            ))}
        </Picker>

        <Toast
            visible={isToastVisible}
            position={'top'}
            autoDismiss={5000}
            onDismiss={toggleToastVisibility}
            backgroundColor="red"
            message={toastMessage}
            messageStyle={styles.errorText}>
        </Toast>

        <Button label={ctx.Translate.get("register-user-page.register")} backgroundColor={"green"} onPress={registerUser}/>
        </GestureHandlerRootView>
    </>);
}