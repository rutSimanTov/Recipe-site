import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipeDatailsComponent } from './recipe-datails.component';

describe('RecipeDatailsComponent', () => {
  let component: RecipeDatailsComponent;
  let fixture: ComponentFixture<RecipeDatailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecipeDatailsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecipeDatailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
