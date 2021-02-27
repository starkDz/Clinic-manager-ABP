import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Clinique',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44324',
    redirectUri: baseUrl,
    clientId: 'Clinique_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone Clinique',
  },
  apis: {
    default: {
      url: 'https://localhost:44324',
      rootNamespace: 'Clinique',
    },
  },
} as Environment;
