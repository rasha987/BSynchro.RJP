import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'RJP',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44322/',
    redirectUri: baseUrl,
    clientId: 'RJP_App',
    responseType: 'code',
    scope: 'offline_access RJP',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44322',
      rootNamespace: 'BSynchro.RJP',
    },
  },
} as Environment;
