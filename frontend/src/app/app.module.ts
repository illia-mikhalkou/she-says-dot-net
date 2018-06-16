import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';

import {
  MatButtonModule,
  MatCardModule,
  MatExpansionModule,
  MatIconModule,
  MatListModule,
  MatPaginatorModule,
  MatSidenavModule,
  MatSortModule,
  MatTableModule,
  MatToolbarModule,
  MatGridListModule } from '@angular/material';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProfileComponent } from './pages/profile/profile.component';
import { ProfilesListComponent } from './pages/profiles-list/profiles-list.component';
import { AppRoutingModule } from './app-routing.module';
import { TransactionHistoryComponent } from './pages/transaction-history/transaction-history.component';

@NgModule({
  declarations: [
    AppComponent,
    ProfileComponent,
    ProfilesListComponent,
    TransactionHistoryComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatCardModule,
    MatExpansionModule,
    MatIconModule,
    MatListModule,
    MatPaginatorModule,
    MatSidenavModule,
    MatSortModule,
    MatTableModule,
    MatToolbarModule,
    MatGridListModule,
    RouterModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
