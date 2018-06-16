import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor() { }

  getProfiles(): Observable<UserProfile[]> {
    return of(this.createMockProfiles());
  }

  getProfile(profileId: number): Observable<UserProfile> {
    return of(this.createMockProfiles().find(up => up.profileId === profileId));
  }

  private createMockProfiles(): UserProfile[] {
    const result: UserProfile[] = [
      {
        birthday: new Date(),
        deptId: 2,
        domenName: 'icx\\dzmitry.bykau',
        email: 'dzmitry.bykau@itexhart-group.com',
        employmentDate: new Date(),
        firstName: 'Dzmitry',
        lastName: 'Bykau',
        group: 'G2',
        firstNameEng: 'Dzmitry',
        image: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
        lastNameEng: 'Bykau',
        middleName: 'Alehandrowich',
        phone: '111 22 3333',
        profileId: 1,
        rank: '.NET developer',
        room: '402',
        skype: 'dzmitry_bykau'
      },
      {
        birthday: new Date(),
        deptId: 2,
        domenName: 'icx\\vasya.pupkin',
        email: 'vasya.pupkin@itexhart-group.com',
        employmentDate: new Date(),
        firstName: 'Vasya',
        lastName: 'Pupkin',
        group: 'G2',
        firstNameEng: 'Vasya',
        image: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
        lastNameEng: 'Bykau',
        middleName: 'Pupkin',
        phone: '111 22 3333',
        profileId: 2,
        rank: '.NET Developer',
        room: '402',
        skype: 'vasya_pupkin'
      },
      {
        birthday: new Date(),
        deptId: 2,
        domenName: 'icx\\petya.ivanou',
        email: 'petya.ivanou@itexhart-group.com',
        employmentDate: new Date(),
        firstName: 'Petya',
        lastName: 'Ivanou',
        group: 'G2',
        firstNameEng: 'Petya',
        image: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
        lastNameEng: 'Ivanou',
        middleName: 'Alehandrowich',
        phone: '111 22 3333',
        profileId: 3,
        rank: '.NET Developer',
        room: '402',
        skype: 'petya_ivanou'
      }
    ];

    return result;
  }
}
