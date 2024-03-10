import { createContext } from 'react';
import { AuthService } from 'common\\services\\authService';
import { TranslatorService } from 'common\\services\\translatorService';
import { UserService } from 'common\\services\\userService';
import * as SecureStore from 'expo-secure-store';

const getToken = (): string => {
    return SecureStore.getItem('token') as string;
}

const setToken = (token:string): void => {
    SecureStore.setItem('token',token);
}

export const services = {
    Auth: new AuthService(setToken, getToken),
    Translate: new TranslatorService(),
    Users: new UserService(setToken, getToken)
}

const ServiceContext = createContext(services);

export default ServiceContext;