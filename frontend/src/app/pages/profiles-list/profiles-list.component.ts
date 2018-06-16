import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'profiles-list',
  templateUrl: './profiles-list.component.html',
  styleUrls: ['./profiles-list.component.scss']
})
export class ProfilesListComponent implements OnInit {

  data: UserProfile[] = [];

  constructor(private userService: UserService) {
    userService.getProfiles().subscribe((data) => this.data = data);
  }

  ngOnInit() {
  }

}
