import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormAlunoRegistroComponent } from './form-aluno-registro.component';

describe('FormAlunoRegistroComponent', () => {
  let component: FormAlunoRegistroComponent;
  let fixture: ComponentFixture<FormAlunoRegistroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormAlunoRegistroComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormAlunoRegistroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
