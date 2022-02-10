
## CQRS (Command Query Responsibility Segregation)
Command ve Query sorumluluklarının ayrılması prensibini esas alan bir  yaklamışımı savunmaktadır.

#### Command
Olmayan veriyi oluşturan ya da var olan bir veri üzerinde güncelleme veya silme 
işlemi yapan isteklerdir.
**INSERT**,**UPDATE**,**DELETE**

#### Query
Mevcut verileri sadece listelemek, okumak yahut sunmak için read işlemi yapan isteklerdir.
**SELECT**

![Dosyalama düzeni](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CQRS/folderStructure_1.png?raw=true)

![Dosyalama düzeni](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CQRS/folderStructure_2.PNG?raw=true)

CQRS, ana odağı write (yazma) ve read (okuma) sorumluluklarının ayrıştırılmasına dayanan bir mimari tasarım modelidir. CQRS mimarisi, CQS ilkesi baz alınarak kurulmuştur. CQS’in ana fikrinden bahsetmek gerekirse; bir metot objenin durumunu değiştirmelidir ya da geriye bir sonuç dönmelidir, ancak 2 işlemi birden yapmamalıdır. 

Uygulamalarınızda CQRS mimari modeline göre oluşturursanız; uygulamanızın performansını, ölçeklenebilirliğini ve güvenliğini en üst düzeye çıkarabilirsiniz.


[Detaylı bilgi için sunum dosyası](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CQRS/CQRS.pptx)
Request ve response modellerini ve bir comand sınıfını aşağıdaki örneklerden inceleyebilirsiniz.

### Create Student Request
```c#
public class CreateStudentRequest
{
    public string StudentName { get; set; }
    public int GradeId { get; set; }
}
```

### Create Student Response
```c#
public class CreateStudentResponse
{
    public string Message { get; set; }
    public bool Success { get; set; } = true;
}
```

### Create Student Command

```c#
public class CreateStudentCommand
{
    private readonly IEfStudentDal _efStudentDal;

    public CreateStudentCommand(IEfStudentDal efStudentDal)
    {
        _efStudentDal = efStudentDal;

    }
    public CreateStudentResponse Handle(CreateStudentRequest request)
    {
        _efStudentDal.Add(request.GetCreateStudent());

        return new CreateStudentResponse {Message = "Student added"};
    }


}
```
   
[Güven Baris Cakan](https://github.com/guvenbaris)