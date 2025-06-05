import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'duration'
})
export class DurationPipe implements PipeTransform {

  transform(value: number): string {
    if(value==1)
      return ""+value+" hour"
    if(value<4)
      return ""+value+" hours"
    else
    return ""+value+" minutes"


  }

}
