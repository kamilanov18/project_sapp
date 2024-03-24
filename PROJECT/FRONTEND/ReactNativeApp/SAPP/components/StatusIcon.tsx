import { useContext } from "react"
import StyleContext from "./StyleContext"
import { Assets, Icon } from "react-native-ui-lib";
import React from "react";

class StatusIconProps {
    id: number;
    size?: number=12;
    tintColor?:string
}

export default function StatusIcon(props:StatusIconProps) {

    const styles=useContext(StyleContext)
    
    Assets.loadAssetsGroup('icons', {
        1: require('../assets/icons/plus-large.png'),
        2: require('../assets/icons/waybill.png'),
        3: require('../assets/icons/shipping.png'),
        4: require('../assets/icons/check.png'),
        5: require('../assets/icons/x.png'),
        6: require('../assets/icons/!.png')
      });
    
    const iconColorMap = {
        1: styles.primary.backgroundColor,
        2: 'green',
        3: 'yellow',
        4: 'green',
        5: 'red',
        6: 'orange'
    }

    return (
        <Icon 
            source={Assets.icons[props.id]}
            size={props.size} 
            tintColor={props.tintColor ?? iconColorMap[props.id]}
        />
    );
}