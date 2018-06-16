import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AuthGuard } from './services/auth.guard';

import { AppComponent } from './app.component';
import { LoginComponent } from './pages/login/login.component';
import { ProfilesListComponent } from './pages/profiles-list/profiles-list.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TransactionHistoryComponent } from './pages/transaction-history/transaction-history.component';

const routes: Routes = [
    {
      path: '',
      pathMatch: 'full',
      redirectTo: 'profile/1'
    },
    {
      path: 'login',
      component: LoginComponent
    },
    {
      path: 'profiles',
      component: ProfilesListComponent,
      canActivate: [AuthGuard]
    },
    {
        path: 'profile/:id',
        component: ProfileComponent,
        canActivate: [AuthGuard]
    },
    {
      path: 'transaction-history',
      component: TransactionHistoryComponent,
      canActivate: [AuthGuard]
    }
];

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [
        RouterModule
    ],
    declarations: []
})
export class AppRoutingModule { }
