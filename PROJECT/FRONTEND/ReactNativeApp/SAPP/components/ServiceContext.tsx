import { createContext } from 'react';
// import { AuthService } from 'common\\services\\authService';
// import { TranslatorService } from 'common\\services\\translatorService';
// import { UserService } from 'common\\services\\userService';
// import { RolesService } from 'common\\services\\rolesService';
import {AuthService} from '../../../Common/services/authService';
import {TranslatorService} from '../../../Common/services/translatorService';
import {UserService} from '../../../Common/services/userService';
import {RolesService} from '../../../Common/services/rolesService';
import { OrdersService } from '../../../Common/services/ordersService';
import * as SecureStore from 'expo-secure-store';
import { CacheService } from '../../../Common/services/cacheService';
import { MMKVLoader } from "react-native-mmkv-storage";
import { NomenclaturesService } from '../../../Common/services/nomenclaturesService';

const MMKV = new MMKVLoader().initialize();

const getToken = (): string => {
    return SecureStore.getItem('token') as string;
}

const setToken = (token:string): void => {
    SecureStore.setItem('token',token);
}

const setCache = (key: string, value: any): void => {
    MMKV.setMap(key, value);
}

const getCache = (key: string): any => {
    return MMKV.getMap(key);
}

export const services = {
    Auth: new AuthService(setToken, getToken),
    Translate: new TranslatorService(),
    Users: new UserService(setToken, getToken),
    Roles: new RolesService(setToken, getToken),
    Orders: new OrdersService(setToken, getToken),
    Cache: new CacheService(setCache, getCache),
    Nomenclatures: new NomenclaturesService(setToken, getToken)
}

const ServiceContext = createContext(services);

export default ServiceContext;