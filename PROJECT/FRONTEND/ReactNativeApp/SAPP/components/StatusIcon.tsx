import { useContext } from "react"
import StyleContext from "./StyleContext"
import { Assets, Icon } from "react-native-ui-lib";
import {Image} from 'react-native'
import React from "react";

class StatusIconProps {
    id: number;
    size?: number=1;
    tintColor?:string
}

Assets.loadAssetsGroup('icons', {
    icon1: require('../assets/icons/plus-large.png'),
    // icon2: require('icon2.png'),
    // icon3: require('icon3.png'),
  });
  

const idToIconMap = [
    require(''),
]

export default function StatusIcon(props:StatusIconProps) {

    const styles=useContext(StyleContext)

    return (
        <>
        <Icon 
            assetName="plus-large" 
            size={props.size} 
            tintColor={props.tintColor ?? styles.primary.backgroundColor}
        />
        {/* <Image source={require("../assets/icons/plus-large.png")} /> */}
        </>
    );
}