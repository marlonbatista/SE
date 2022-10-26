import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormOrganizacionalTurmaComponent } from './form-organizacional-turma.component';

describe('FormOrganizacionalTurmaComponent', () => {
  let component: FormOrganizacionalTurmaComponent;
  let fixture: ComponentFixture<FormOrganizacionalTurmaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormOrganizacionalTurmaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormOrganizacionalTurmaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
