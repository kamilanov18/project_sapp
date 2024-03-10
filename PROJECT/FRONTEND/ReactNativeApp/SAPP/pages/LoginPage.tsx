import { Assets, Button, Icon, Incubator, TextField } from "react-native-ui-lib";
import ServiceContext from "../components/ServiceContext";
import { useContext, useState } from "react";
import React from "react";
import { LoginResponseStatusEnum } from 'common\\DTOs\\LoginResponseStatusEnum';
import {NativeStackNavigationProp} from '@react-navigation/native-stack';
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { StyleSheet } from 'react-native';

interface Props {
    navigation: NativeStackNavigationProp<any,any>
}

const {Toast} = Incubator;

export default function LoginPage({navigation}:Props) {
    let ctx = useContext(ServiceContext);
    let [email, setEmail] = useState('');
    let [password, setPassword] = useState('');
    let [isToastVisible, setIsToastVisible] = useState(false);
    let [toastMessage, setToastMessage] = useState('');
    let toggleToastVisibility = () => setIsToastVisible(!isToastVisible);

    const submit = async () => {
        const res = await ctx.Auth.login({email: email, password: password})
        switch (res) {
            case LoginResponseStatusEnum.success: {
                navigation.navigate('Home'); 
                break;
            }
            case LoginResponseStatusEnum.invalidPassword: {
                setIsToastVisible(true); 
                setToastMessage(ctx.Translate.get("login-page.invalid-password")); 
                break;
            }
            case LoginResponseStatusEnum.noEmailFound: {
                setIsToastVisible(true); 
                setToastMessage(ctx.Translate.get("login-page.invalid-email")); 
                break;
            }
            case LoginResponseStatusEnum.firstTimeLogin: {
                navigation.navigate('ChangePassword'); 
                break;
            }
        }
    }

    return (
        <>
        <GestureHandlerRootView>
            <TextField
                placeholder={ctx.Translate.get("login-page.email")}
                floatingPlaceholder
                onChangeText={setEmail}
            />
    
            <TextField
                placeholder={ctx.Translate.get("login-page.password")}
                floatingPlaceholder
                secureTextEntry
                onChangeText={setPassword}
            />

            <Button label={ctx.Translate.get("login-page.login")} onPress={submit} />

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