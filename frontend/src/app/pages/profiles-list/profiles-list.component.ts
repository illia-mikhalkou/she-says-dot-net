import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'profiles-list',
  templateUrl: './profiles-list.component.html',
  styleUrls: ['./profiles-list.component.scss']
})
export class ProfilesListComponent implements OnInit {

  data: UserProfile[] = [];

  constructor(private userService: UserService, private router: Router) {
    userService.getProfiles().subscribe((data) => this.data = data);
  }

  ngOnInit() {
  }


  onItemViewClick(profileId: number) {
    this.router.navigate([`profile/${profileId}`]);
  }
}
