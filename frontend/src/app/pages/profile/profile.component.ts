import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Subscription } from 'rxjs/internal/Subscription';

import { UserService } from './../../services/user.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit, OnDestroy {

  private subscription: Subscription;

  userId: number;

  userProfile: UserProfile;
  achievements = [{
    image: 'http://wow.zamimg.com/images/wow/icons/large/achievement_arena_2v2_7.jpg',
    userName: 'Vasya Pupkin',
    comment: 'Just a great guy!'
  }];

  constructor(private route: ActivatedRoute, private userService: UserService) {

  }

  ngOnInit() {
    this.subscription = this.route.params.subscribe(params => {
      this.userId = +params['id'];
      this.userService.getProfile(this.userId).subscribe(resp => {
        this.userProfile = resp;
      });
    });
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }
}
