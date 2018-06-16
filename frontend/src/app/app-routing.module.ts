import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { ProfilesListComponent } from './pages/profiles-list/profiles-list.component';
import { ProfileComponent } from './pages/profile/profile.component';

const routes: Routes = [
    {
        path: 'profiles',
        component: ProfilesListComponent,
    },
    {
        path: 'profile',
        component: ProfileComponent
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