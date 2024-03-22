import { useContext } from "react"
import StyleContext from "./StyleContext"
import { Assets, Icon } from "react-native-ui-lib";
import React from "react";

class StatusIconProps {
    id: number;
    size?: number=12;
    tintColor?:string
}

Assets.loadAssetsGroup('icons', {
    icon1: require('../assets/icons/plus-large.png'),
    // icon2: require('icon2.png'),
    // icon3: require('icon3.png'),
  });

export default function StatusIcon(props:StatusIconProps) {

    const styles=useContext(StyleContext)

    return (
        <Icon 
            source={Assets.icons.icon1}
            size={props.size} 
            tintColor={props.tintColor ?? styles.primary.backgroundColor}
        />
    );
}