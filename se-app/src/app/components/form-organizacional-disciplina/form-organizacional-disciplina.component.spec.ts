import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormOrganizacionalDisciplinaComponent } from './form-organizacional-disciplina.component';

describe('FormOrganizacionalDisciplinaComponent', () => {
  let component: FormOrganizacionalDisciplinaComponent;
  let fixture: ComponentFixture<FormOrganizacionalDisciplinaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormOrganizacionalDisciplinaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormOrganizacionalDisciplinaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
