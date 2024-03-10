import React, { useContext } from "react";
import { Button, TextField, Incubator } from "react-native-ui-lib";
import ServiceContext from "../components/ServiceContext";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { StyleSheet } from 'react-native';

const {Toast} = Incubator;

export default function ChangePasswordPage() {
    const ctx = useContext(ServiceContext);
    const [password, setPassword] = React.useState('');
    const [confirmPassword, setConfirmPassword] = React.useState('');
    const [isToastVisible, setIsToastVisible] = React.useState(false);
    const [toastMessage, setToastMessage] = React.useState('');
    const toggleToastVisibility = () => setIsToastVisible(!isToastVisible);

    const submit = async () => {
        if (password !== confirmPassword) {
            setIsToastVisible(true); 
            setToastMessage(ctx.Translate.get("change-password-page.passwords-dont-match"));
            return;
        }
        const res = await ctx.Auth.changePassword(password);
        if (res) {
            setIsToastVisible(true); 
            setToastMessage(ctx.Translate.get("change-password-page.password-changed"));
        }
    }
    return (
        <>
        <GestureHandlerRootView>
            <TextField
                placeholder={ctx.Translate.get("change-password-page.password")}
                floatingPlaceholder
                secureTextEntry
                onChangeText={setPassword}
            />
    
            <TextField
                placeholder={ctx.Translate.get("change-password-page.confirm-password")}
                floatingPlaceholder
                secureTextEntry
                onChangeText={setConfirmPassword}
            />

            <Button label={ctx.Translate.get("change-password-page.-change-password")} onPress={submit} />

            <Toast
                visible={isToastVisible}
                position={'top'}
                autoDismiss={5000}
                onDismiss={toggleToastVisibility}
                backgroundColor="red"
                message={toastMessage}
                messageStyle={styles.text}>
            </Toast>
            </GestureHandlerRootView>
        </>
    );
}

const styles = StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: '#fff',
      alignItems: 'center',
      justifyContent: 'center',
    },
    text: {
        color: 'white',
        fontWeight: 'bold',
        textAlign: 'center'
    }
});