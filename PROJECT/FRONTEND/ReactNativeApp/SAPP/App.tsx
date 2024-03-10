import { StyleSheet } from 'react-native';
import LoginPage from './pages/LoginPage';
import React, { useContext } from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import OrdersPage from './pages/OrdersPage';
import ServiceContext from './components/ServiceContext';
import ChangePasswordPage from './pages/ChangePasswordPage';
import HomePage from './pages/HomePage';

const Stack = createNativeStackNavigator();

export default function App() {
  const ctx = useContext(ServiceContext);
  return (
    <>
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen
          name="Login"
          component={LoginPage}
          options={{ title: ctx.Translate.get('login-page.title'), headerShown: false}}
        />
        <Stack.Screen
          name="Home"
          component={HomePage}
          options={{ title: ctx.Translate.get('home-page.title'), headerShown: false}}
        />
        <Stack.Screen name="ChangePassword" component={ChangePasswordPage} options={{ title: ctx.Translate.get('change-password-page.title')}}/>
      </Stack.Navigator>
    </NavigationContainer>
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
});
