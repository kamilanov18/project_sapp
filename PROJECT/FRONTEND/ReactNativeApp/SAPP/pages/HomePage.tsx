import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import React, { useContext } from 'react';
import ServiceContext from '../components/ServiceContext';
import ProductsPage from './ProductsPage';
import ProfilePage from './ProfilePage';
import ActionsPage from './ActionsPage';
import { Assets, Icon } from 'react-native-ui-lib';
import MainUsersPage from './Users/MainUsersPage';
import MainOrdersPage from './Orders/MainOrdersPage';
import StyleContext from '../components/StyleContext';
const Tab = createBottomTabNavigator();

type iconFactoryType = ((props: {
    focused: boolean;
    color: string;
    size: number;
}) => React.ReactNode) | undefined;

export default function HomePage() {
    const ctx = useContext(ServiceContext);
    const styles = useContext(StyleContext);
    const roles:string[] = ctx.Auth.getRoles();

    const iconFactory = (asset: any, color: string=styles.primary.backgroundColor, size: number=22): iconFactoryType => {
        return  (() => <Icon source={asset} size={size} tintColor={color} />);
    }
    
    Assets.loadAssetsGroup('icons', {
        "orders": require('../assets/icons/orders.png'),
        "users": require('../assets/icons/users.png'),
        "products": require('../assets/icons/box.png'),
        "actions": require('../assets/icons/actions.png'),
        "profile": require('../assets/icons/profile.png'),
      });

    return (
        <Tab.Navigator>
            {ctx.Auth.allowRoles(["admin","operator","packager"]) && 
                <Tab.Screen 
                    name='MainOrdersPage' 
                    component={MainOrdersPage} 
                    options={{ title: ctx.Translate.get('orders-page.title'), tabBarIcon: iconFactory(Assets.icons["orders"]),headerShown: false}}
                />
            }
            {ctx.Auth.allowRoles(["admin"]) && 
                <Tab.Screen 
                    name='MainUsersPage'
                    component={MainUsersPage} 
                    options={{ title: ctx.Translate.get('users-page.title'), headerShown: false, tabBarIcon: iconFactory(Assets.icons["users"])}}
                />
            }
            {ctx.Auth.allowRoles(["admin"]) && 
                <Tab.Screen 
                name='Products' 
                component={ProductsPage} 
                options={{ title: ctx.Translate.get('products-page.title'), tabBarIcon: iconFactory(Assets.icons["products"])}}
                />
            }
            {ctx.Auth.allowRoles(["admin"]) && 
                <Tab.Screen 
                    name='Actions' 
                    component={ActionsPage} 
                    options={{ title: ctx.Translate.get('actions-page.title'), tabBarIcon: iconFactory(Assets.icons["actions"])}}
                />
            }
            <Tab.Screen 
                name='Profile' 
                component={ProfilePage} 
                options={{ title: ctx.Translate.get('profile-page.title'), tabBarIcon: iconFactory(Assets.icons["profile"])}}
            />
        </Tab.Navigator>
    );
}