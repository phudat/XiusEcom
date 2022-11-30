import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'XiusEcom',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44345/',
    redirectUri: baseUrl,
    clientId: 'XiusEcom_App',
    responseType: 'code',
    scope: 'offline_access XiusEcom',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44317',
      rootNamespace: 'XiusEcom',
    },
  },
} as Environment;
