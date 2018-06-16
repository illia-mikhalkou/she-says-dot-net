import { Component, OnInit, Input } from '@angular/core';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'profile-list-item',
  templateUrl: './profile-list-item.component.html',
  styleUrls: ['./profile-list-item.component.scss']
})
export class ProfileListItemComponent implements OnInit {

  @Input()
  profile: UserProfile;

  constructor(private userService: UserService) { }

  ngOnInit() {
  }

}
