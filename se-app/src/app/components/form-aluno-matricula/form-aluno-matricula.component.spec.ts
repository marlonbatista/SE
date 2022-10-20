import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormAlunoMatriculaComponent } from './form-aluno-matricula.component';

describe('FormAlunoMatriculaComponent', () => {
  let component: FormAlunoMatriculaComponent;
  let fixture: ComponentFixture<FormAlunoMatriculaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormAlunoMatriculaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormAlunoMatriculaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
