import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import React, { useContext } from 'react';
import ServiceContext from '../components/ServiceContext';
import ProductsPage from './ProductsPage';
import ProfilePage from './ProfilePage';
import ActionsPage from './ActionsPage';
import { Assets, Icon } from 'react-native-ui-lib';
import MainUsersPage from './Users/MainUsersPage';
import MainOrdersPage from './Orders/MainOrdersPage';
const Tab = createBottomTabNavigator();

type iconFactoryType = ((props: {
    focused: boolean;
    color: string;
    size: number;
}) => React.ReactNode) | undefined;

const iconFactory = (asset: any, color: string, size: number): iconFactoryType => {
    return  (() => <Icon source={asset} size={size} tintColor={color} />);
}

export default function HomePage() {
    const ctx = useContext(ServiceContext);
    const roles:string[] = ctx.Auth.getRoles();
    return (
        <Tab.Navigator>
            {ctx.Auth.allowRoles(["admin","operator","packager"]) && 
                <Tab.Screen 
                    name='MainOrdersPage' 
                    component={MainOrdersPage} 
                    options={{ title: ctx.Translate.get('orders-page.title'), tabBarIcon: iconFactory(Assets.icons.search,"red",12) }}
                />
            }
            {ctx.Auth.allowRoles(["admin"]) && 
                <Tab.Screen 
                    name='MainUsersPage'
                    component={MainUsersPage} 
                    options={{ title: ctx.Translate.get('users-page.title'), headerShown: false}}
                />
            }
            {ctx.Auth.allowRoles(["admin"]) && 
                <Tab.Screen 
                name='Products' 
                component={ProductsPage} 
                options={{ title: ctx.Translate.get('products-page.title')}}
                />
            }
            {ctx.Auth.allowRoles(["admin"]) && 
                <Tab.Screen 
                    name='Actions' 
                    component={ActionsPage} 
                    options={{ title: ctx.Translate.get('actions-page.title')}}
                />
            }
            <Tab.Screen 
                name='Profile' 
                component={ProfilePage} 
                options={{ title: ctx.Translate.get('profile-page.title')}}
            />
        </Tab.Navigator>
    );
}