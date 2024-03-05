import { Button, TextField } from "react-native-ui-lib";
import ServiceContext from "../components/ServiceContext";
import { useContext, useState } from "react";

export default function Login() {
    let ctx = useContext(ServiceContext);
    let [email, setEmail] = useState('');
    let [password, setPassword] = useState('');
    const submit = () => {
        ctx.Auth.login({email: email, passwordHash: password})
    }
    return (
        <>
            <TextField
                placeholder={'Email'}
                floatingPlaceholder
                showCharCounter
                maxLength={30}
                onChangeText={setEmail}
            />
    
            <TextField
                placeholder={'Password'}
                floatingPlaceholder
                showCharCounter
                maxLength={30}
                onChangeText={setPassword}
            />

            <Button onPress={submit}>Login</Button>
        </>
    );
}