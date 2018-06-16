import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'profile-list-item',
  templateUrl: './profile-list-item.component.html',
  styleUrls: ['./profile-list-item.component.scss']
})
export class ProfileListItemComponent implements OnInit {

  @Input()
  profile: UserProfile;

  constructor() { }

  ngOnInit() {
    console.log(this.profile);
  }

}
