import { createContext } from "react";
import { StyleSheet } from 'react-native';

const styles = StyleSheet.create({
    errorText: {
        color: 'white',
        fontWeight: 'bold',
        textAlign: 'center'
    }
});

const StyleContext = createContext(styles);

export default StyleContext;