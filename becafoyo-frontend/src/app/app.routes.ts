import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'vehicles',
    loadComponent: () =>
      import('./features/vehicle-catalog/vehicle-catalog.component').then(
        (c) => c.VehicleCatalogComponent
      ),
  },
  {
    path: 'selling',
    loadComponent: () => 
        import('./features/sell-vehicle/sell-vehicle.component').then(
            (c) => c.SellVehicleComponent
        )
  },
  {
    path: 'healthcheck',
    loadComponent: () => 
        import('./features/vehicle-health-check/vehicle-health-check.component').then(
            (c) => c.VehicleHealthCheckComponent
        )
  }
];
