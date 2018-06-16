import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'profile-list-item',
  templateUrl: './profile-list-item.component.html',
  styleUrls: ['./profile-list-item.component.scss']
})
export class ProfileListItemComponent implements OnInit {

  @Input()
  profile: UserProfile;

  @Output()
  viewClick: EventEmitter<number> = new EventEmitter();

  @Output()
  giveBadgeClick: EventEmitter<number> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  onViewClick(profileId: number) {
    this.viewClick.emit(profileId);
  }

  ongiveBadgeClick(profileId: number) {
    this.viewClick.emit(profileId);
  }
}
