import { Component } from '@angular/core';
import { ExaminationService } from './services/examinationService';
import { Accessor } from './models/accessor';
import { CookieService } from 'ngx-cookie-service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'OnlineExaminationApplication';
  displayName: string = "User";
  constructor(private cookieService: CookieService, private examService: ExaminationService) {
  }
  logOut() {
    //this.examService.setAccessor(new Accessor);
    this.cookieService.delete('Type');
    this.cookieService.delete('Name');
    this.cookieService.delete('Email');
    this.cookieService.delete('Id');
  }
  ngDoCheck() {
    const tempName = this.cookieService.get('Name');
    if (tempName)
      this.displayName = tempName;
    else
      this.displayName = "User";
  }
}
