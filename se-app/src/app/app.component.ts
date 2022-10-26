import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { filter, map, switchMap } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  userConected: boolean = true;
  userAdmin: boolean = true;

  // title = 'Projeto S.E.';

  constructor(
    activatedRoute: ActivatedRoute,
    router: Router,
    titleService: Title
  ) {
    router.events
      .pipe(filter((event) => event instanceof NavigationEnd))
      .pipe(map(() => activatedRoute))
      .pipe(
        map((route) => {
          while (route.firstChild) route = route.firstChild;
          return route;
        })
      )
      .pipe(switchMap((route) => route.data))
      .subscribe((event) => titleService.setTitle(event['titulo']));
  }
}
