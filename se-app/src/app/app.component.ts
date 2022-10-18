import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  userConected: boolean = true;
  userAdmin: boolean = false;

  title = 'se-app';
}
