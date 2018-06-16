import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  username: string;
  password: string;

  constructor(private router: Router, private authService: AuthService) {

  }

  ngOnInit() {
  }

  login(): void {
    this.authService.login(this.username, this.password)
      .subscribe((response: LoginResponse) => {
        localStorage.setItem('session_id', response.SessionId.toString());
        this.router.navigateByUrl('profile/1');
      });
  }
}
