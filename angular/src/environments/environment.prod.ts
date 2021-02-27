import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
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
    scope: 'offline_access Clinique',
  },
  apis: {
    default: {
      url: 'https://localhost:44324',
      rootNamespace: 'Clinique',
    },
  },
} as Environment;
