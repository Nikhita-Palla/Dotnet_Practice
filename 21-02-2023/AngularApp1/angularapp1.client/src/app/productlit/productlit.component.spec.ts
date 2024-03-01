import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductlitComponent } from './productlit.component';

describe('ProductlitComponent', () => {
  let component: ProductlitComponent;
  let fixture: ComponentFixture<ProductlitComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ProductlitComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProductlitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
