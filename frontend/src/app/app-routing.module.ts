import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { ProfilesListComponent } from './pages/profiles-list/profiles-list.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TransactionHistoryComponent } from './pages/transaction-history/transaction-history.component';

const routes: Routes = [
    {
        path: 'profiles',
        component: ProfilesListComponent,
    },
    {
        path: 'profile/:id',
        component: ProfileComponent
    },
    {
      path: 'transaction-history',
      component: TransactionHistoryComponent
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
