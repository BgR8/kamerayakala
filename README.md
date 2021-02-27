## AForge.NET kütüphanesini kur
```
using AForge.Video;
using AForge.Video.DirectShow;
```


## Bilgisayara bağlı kameraları dizinde tut
`FilterInfoCollection`
## Kamerayı Yakala
`VideoCaptureDevice`

## Kameraları Liste kutusunda Listele
```
foreach(FilterInfo f in fico)
    {
        comboBox1.Items.Add(f.Name);
        comboBox1.SelectedIndex = 0;
    }
```

## Başlat butonu ile listede seçili kamerayı göster.
