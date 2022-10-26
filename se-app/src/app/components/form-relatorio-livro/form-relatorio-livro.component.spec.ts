import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormRelatorioLivroComponent } from './form-relatorio-livro.component';

describe('FormRelatorioLivroComponent', () => {
  let component: FormRelatorioLivroComponent;
  let fixture: ComponentFixture<FormRelatorioLivroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormRelatorioLivroComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormRelatorioLivroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
