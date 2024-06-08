import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinqdictionaryComponent } from './linqdictionary.component';

describe('LinqdictionaryComponent', () => {
  let component: LinqdictionaryComponent;
  let fixture: ComponentFixture<LinqdictionaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LinqdictionaryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LinqdictionaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
