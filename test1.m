clear all
clc
seed=1;
y1out=zeros(100,100);
sign1=ones(3,1);
seed_arr=randi([1,1000],100,1);
for i=1:100
    seed=seed_arr(i,1);
    sim("test01.slx");
    y1out(:,i)=y1;
end
k1_t=y1out(:,1:3);
y1_t=y1out(:,1:80);
save k1.mat k1_t;
save y1.mat y1_t;
% stairs(tout,y1,'LineWidth',1,'Color','k')
% xlabel("时间（秒）")
% ylabel("输出值（无量纲）")



% y01=[y1_t',sign1];
% fid = fopen('y1.txt','wt');
% [m,n]=size(y01); 
% for i=1:1:m 
% for j=1:1:n 
% if j==n 
% fprintf(fid,'%g\n',y01(i,j)); 
% else 
% fprintf(fid,'%g\t',y01(i,j)); 
% end 
% end 
% end 
% fclose(fid);