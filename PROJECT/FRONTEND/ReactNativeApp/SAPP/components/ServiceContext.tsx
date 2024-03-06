import { createContext } from 'react';
import { AuthService } from 'common\\services\\authService';
import * as SecureStore from 'expo-secure-store';

const getToken = (): string => {
    return SecureStore.getItem('token') as string;
}

const setToken = (token:string): void => {
    SecureStore.setItem('token',token);
}

export const services = {
    Auth: new AuthService(setToken, getToken),
}

const ServiceContext = createContext(services);

export default ServiceContext;