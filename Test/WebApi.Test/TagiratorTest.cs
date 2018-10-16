﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApi.EF.Models;
using Xunit;

namespace WebApi.Test
{
    public class TagiratorTest : IDisposable
    {
        public void Dispose()
        {
            _context.Dispose();
        }

        private readonly EFContext _context;

        public TagiratorTest()
        {
            _context = new EFContext(new DbContextOptionsBuilder<EFContext>().UseInMemoryDatabase("Test_BD").Options);
            _context.Articles.Add(new Article("Да да Заглавие",
                "Огроманя статья исполльзуящая огромное колличество буков и слов я хз что сюда еще написать для размера"));
            _context.Articles.Add(new Article("Да да Заглавие",
                "Огроманя статья исполльзуящая огромное колличество буков и слов я хз что сюда еще написать для размера"));
            _context.Articles.Add(new Article("Да да Заглавие",
                "Огроманя статья исполльзуящая огромное колличество буков и слов я хз что сюда еще написать для размера"));
            _context.Articles.Add(new Article("Да да Заглавие1",
                "Огроманя статья исполльзуящая немного меньшее колличество буков"));
            _context.Articles.Add(new Article("8 Врат",
                @"Восемь Врат (яп. 八門 Хатимон) — восемь особых точек в системе циркуляции чакры, ограничивающих её поток по телу с целью уменьшения её расхода и увеличения «срока службы» тех или иных органов. Открытие этих врат позволяет ускорить поток чакры и таким образом увеличить свои силовые возможности, что, тем не менее, может навредить организму или даже обернуться смертью, в связи с чем эта техника относится к запрещённым.
На данный момент в манге указано, что Рок Ли способен открывать шесть врат[2], а его учитель, Майто Гай и его отец, Майто Дай, открывали восемь врат. Также во время тренировок по скалолазанию и сражения с Какудзу одни врата открывал Какаси Хатакэ, что, возможно, не является для него пределом.
Схема расположения Восьми Врат: 1-е и 2-е расположены в головном мозге, врата с 3-х по 7-е в спинном мозге, 8-е врата в сердце
Ниже приведены названия врат и влияние, которое они оказывают на открывшего их ниндзя:
    Врата Начала (яп. 開門 Каймон) позволяют использовать технику Первичного Лотоса (яп. 表蓮華 Омотэ Рэнгэ), первый этап которой состоит в обездвиживании противника в полёте за счёт оборачивания того с помощью лент. Затем, пользователь захватывает своего врага и устремляется головой вниз, падая на землю, таким образом нанося противнику серьёзные травмы.
    Врата Покоя (яп. 休門 Кю:мон) — с мышц снимается напряжение, таким образом увеличивая выносливость ниндзя.
    Врата Жизни (яп. 生門 Сэймон) — на этом уровне пользователь способен выполнить Обратный Лотос (яп. 裏蓮華 Ура Рэнгэ)[3], являющийся более сложной версией Переднего Лотоса. Эта техника используется в воздухе, где сначала противнику руками и ногами наносятся мощные и быстрые удары, а затем его разбивают о землю.
    Врата Боли (яп. 傷門 Сё:мон) — сила и скорость ниндзя значительно возрастают. Тело работает на пределе своих возможностей — высокие нагрузки начинают разрывать мышцы.
    Врата Предела (яп. 杜門 Томон) — дальнейшее увеличение физических возможностей.
    Врата Вида (яп. 景門 Кэймон) — на этом уровне возможно исполнять дзюцу Утреннего Павлина[4] (яп. 朝孔雀 Аса Кудзяку), благодаря которому удары становятся такими быстрыми и мощными, что вокруг кулака формируется яркая чакра.
    Врата Потрясения (яп. 驚門 Кё:мон) — дальнейшее увеличение силы ударов и скорости перемещения. При открытии семи врат возможно использование т. н. техники Полуденный тигр (яп. 昼虎 Хиру:дора), удар которой фокусирует огромное атмосферное давление, которое приобретает форму тигра, на противнике, а затем взрывает всё в один момент[5].
    Врата Смерти (яп. 死門 Симон) — последние и самые мощные врата, открытие которых провоцирует расход всей энергии тела. При открытии восьмых врат возможно использование техники Вечерний Слон (яп. 夕象 Сэкидзо), которая позволяет нанести по противнику пять сокрушительных ударов (足, Соку), каждый из которых превосходит по скорости предыдущий, а также техники Ночной Гай (яп. 夜ガイ Ягай). Данные техники дают пользователю силу, превышающую даже уровень техник ранга S, благодаря тому, что сердце начинает работать на своём максимуме. Однако этот эффект «большого взрыва» является временным, который, прекратившись, разрушает в теле все мускулы, включая сердечную мышцу. Человека, открывшего Врата Смерти, ждёт верная гибель — тело синоби обращается в пепел."));
            _context.Articles.Add(new Article("Да да Заглавие1",
                "Огроманя статья исполльзуящая немного меньшее колличество буков Огроманя статья исполльзуящая немного меньшее колличество буков"));
            _context.Articles.Add(new Article("Да да Заглавие1",
                "Огроманя статья исполльзуящая немного меньшее колличество буков Огроманя статья исполльзуящая немного меньшее колличество буков Огроманя статья исполльзуящая немного меньшее колличество буков"));
            _context.Articles.Add(new Article("Да да Заглавие1",
                "ывааываукпеукпукфцуц фыавпапкцпцупкцыукуепе фывваолрорлфыварполфывапроауцфакпролнапросывмя олрфвыпарололфвпарлгподукфаагнпшелкфвупапролвам"));
            _context.SaveChanges();
        }

        //private List<Article> Articles;

        [Fact]
        public void Can_Initialize_Tagirator()
        {
            Tagirator.Tagirator.AddContextForTagging(_context);
            Tagirator.Tagirator.SetTagsInArticle();
            _context.SaveChanges();

            Tagirator.Tagirator.AddContextForTagging(_context);
            Tagirator.Tagirator.SetTagsInArticle();
            _context.SaveChanges();

            Assert.NotEmpty(_context.Articles);
            Assert.NotNull(_context.Articles.FirstOrDefault());
            Assert.NotEmpty(_context.Tags);
            Assert.NotEmpty(_context.ArticleTags);
        }

        //[Fact]
        //public void Can_Set_Words_rate()
        //{
        //    var pool = new ArticleTagirator(Articles);
        //    pool.SetWordsRate();
        //    //Assert.NotEmpty(pool.GlobalDictionary);
        //    Assert.NotEmpty(Articles.First().Tags);
        //}
    }
}