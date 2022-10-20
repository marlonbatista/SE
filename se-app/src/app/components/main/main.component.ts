import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  mostrarInfo: boolean = false;

  titulo!: string;

  constructor(private route: ActivatedRoute, private router: Router ) { }

  ngOnInit() {
    this.router.events.subscribe(event => {
      if(event instanceof NavigationEnd) {
        this.titulo = this.route.root.firstChild?.snapshot.data['titulo'];
      }
    });
  }    

}
