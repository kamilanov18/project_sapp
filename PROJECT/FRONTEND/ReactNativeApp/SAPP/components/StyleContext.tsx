import { createContext } from "react";
import { StyleSheet } from 'react-native';

const styles = StyleSheet.create({
    errorText: {
        color: 'white',
        fontWeight: 'bold',
        textAlign: 'center'
    },
    primaryText: {
        color:'black',

    },
    primary: {
        backgroundColor:'#0362fc'
    },
    iconBox:{
        flex:0.5,
        marginRight:5,
        padding:5
    },
    drawerItem: {
        height: 100,
        flexDirection:"row",
        justifyContent:"center",
        borderBottomWidth:1,
        borderBottomColor:'#7a7a7a',
    },
    duplicateDrawerItem: {
        height: 100,
        flexDirection:"row",
        justifyContent:"center",
        backgroundColor: '#ffd36b',
        borderStyle: 'dashed',
        borderWidth:3,
        borderColor: '#a87702'
    }
});

const StyleContext = createContext(styles);

export default StyleContext;