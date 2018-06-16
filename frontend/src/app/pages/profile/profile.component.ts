import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Subscription } from 'rxjs/internal/Subscription';

import { UserProfile, ProfileAchievement } from './../../interfaces';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit, OnDestroy {

  private subscription: Subscription;

  userId: number;

  userProfile: UserProfile;
  achievements: ProfileAchievement[] = [];

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.subscription = this.route.params.subscribe(params => {
      this.userId = +params['id'];
    });
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }
}
