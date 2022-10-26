import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormOrganizacionalSerieComponent } from './form-organizacional-serie.component';

describe('FormOrganizacionalSerieComponent', () => {
  let component: FormOrganizacionalSerieComponent;
  let fixture: ComponentFixture<FormOrganizacionalSerieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormOrganizacionalSerieComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormOrganizacionalSerieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
