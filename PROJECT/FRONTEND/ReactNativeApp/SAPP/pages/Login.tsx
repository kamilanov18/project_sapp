import { TextField } from "react-native-ui-lib";

export default function Login() {
    return (
        <TextField
            placeholder={'Placeholder'}
            floatingPlaceholder
            showCharCounter
            maxLength={30}
        />
    );
}